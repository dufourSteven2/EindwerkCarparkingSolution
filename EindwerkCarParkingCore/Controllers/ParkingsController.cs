﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using EindwerkCarParkingCore.Data;
using EindwerkCarParkingCore.Models;
using EindwerkCarParkingLib;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EindwerkCarParkingCore.Controllers
{
    [Route("api/[Controller]")]
   // [Authorize(AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme)]
    public class ParkingsController : Controller  //: controller aangepast naar ApiController
    {
        private readonly IParkingRepository _repository;
        private readonly ILogger<ParkingsController> _logger;
        private readonly IMapper _mapper;
        

        public ParkingsController(IParkingRepository repository, ILogger<ParkingsController>logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

       
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
              //  var username = User.Identity.Name;
               // var results = _repository.GetAllParkingsByUser();
                return Ok(_mapper.Map<IEnumerable<Parking>,IEnumerable<ParkingsDTO>> (_repository.GetAllRegistredParkings()));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get Parkingen: {ex}");
                return BadRequest("Failed to get Parkingen");
            }
        }


        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                var parking = _repository.GetParkingById(id);
                if (parking != null) return Ok(_mapper.Map<Parking, ParkingsDetailDTO>(parking));
                else return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get Parkingen: {ex}");
                return BadRequest("Failed to get Parkingen");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Parking model)
        {
            //add to db
            try
            {
                _repository.AddEntity(model);
                if (_repository.SaveAll())
                {
                    return Created($"api/parkings/{model.Id}", model);
                }



            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to save a new Parking {ex}");
            }
            return BadRequest("Failed to save new order");

        }
        // put bijgeplaatst
        [HttpPut]
        public IActionResult Put([FromBody]Parking model)
        {
            //add to db
            try
            {
                _repository.AddEntity(model);
                if (_repository.SaveAll())
                {
                    return Created($"api/parkings/{model.Id}", model);
                }



            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to save a new Parking {ex}");
            }
            return BadRequest("Failed to save new order");

        }
    }

}
