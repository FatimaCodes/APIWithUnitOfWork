using APIWithUnitOfWork.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using APIWithUnitOfWork.Models;

namespace APIWithUnitOfWork.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DoctorController> _logger;
        private readonly IMapper _mapper;

        public DoctorController(IUnitOfWork unitOfWork, ILogger<DoctorController> logger,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDoctors()
        {
            try
            {
                var Doctors = await _unitOfWork.Doctors.GetAll();
                var results = _mapper.Map<IList<DoctorDTO>>(Doctors);
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(GetDoctors)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [Authorize]
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDoctor(int id)
        {
            try
            {
                var Doctor = await _unitOfWork.Doctors.Get(q => q.Id == id, new List<string> { "Country" });
                var result = _mapper.Map<DoctorDTO>(Doctor);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(GetDoctor)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }
    }
}
