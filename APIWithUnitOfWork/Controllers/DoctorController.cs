using APIWithUnitOfWork.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using APIWithUnitOfWork.Models;
using Microsoft.AspNetCore.Authorization;
using APIWithUnitOfWork.Data;

namespace APIWithUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
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

        [HttpGet("{id:int}", Name = "GetDoctor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDoctor(int id)
        {
            try
            {
                var Doctor = await _unitOfWork.Doctors.Get(q => q.Id == id);
                var result = _mapper.Map<DoctorDTO>(Doctor);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(GetDoctor)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateDoctor([FromBody] CreateDoctorDTO DoctorDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateDoctor)}");
                return BadRequest(ModelState);
            }

            try
            {
                var doctor = _mapper.Map<Doctor>(DoctorDTO);
                await _unitOfWork.Doctors.Insert(doctor);
                await _unitOfWork.Save();

                return CreatedAtRoute("GetDoctor", new { id = doctor.Id }, doctor);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(CreateDoctor)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        //[Authorize]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateDoctor(int id, [FromBody] UpdateDoctorDTO DoctorDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateDoctor)}");
                return BadRequest(ModelState);
            }

            try
            {
                var Doctor = await _unitOfWork.Doctors.Get(q => q.Id == id);
                if (Doctor == null)
                {
                    _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateDoctor)}");
                    return BadRequest("Submitted data is invalid");
                }

                _mapper.Map(DoctorDTO, Doctor);
                _unitOfWork.Doctors.Update(Doctor);
                await _unitOfWork.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(UpdateDoctor)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteDoctor)}");
                return BadRequest();
            }

            try
            {
                var Doctor = await _unitOfWork.Doctors.Get(q => q.Id == id);
                if (Doctor == null)
                {
                    _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteDoctor)}");
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.Doctors.Delete(id);
                await _unitOfWork.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(DeleteDoctor)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }
    }
}
