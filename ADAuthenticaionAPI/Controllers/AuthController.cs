using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADAuthenticaionAPI.Data.DTOs;
using ADAuthenticaionAPI.Models;
using ADAuthenticaionAPI.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ADAuthenticaionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;

        public AuthController(IAuthRepository repo, IConfiguration config, IMapper mapper)
        {
            _repo = repo;
            _config = config;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegistrationDto userForRegistrationDto)
        {
            // Reqeust Validated through DTO and [APIController]

            userForRegistrationDto.Username = userForRegistrationDto.Username.ToLower();

            if (await _repo.UserExists(userForRegistrationDto.Username))
            {
                return BadRequest("Username already exists");
            }

            var userToCreate = _mapper.Map<User>(userForRegistrationDto);

            var createdUser = await _repo.Register(userToCreate, userForRegistrationDto.Password);

            var userToReturn = _mapper.Map<UserForReturnDto>(createdUser);

            return Ok(userToReturn);

        }
    }
}