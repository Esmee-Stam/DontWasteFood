using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DontWasteFood.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController(IReservationService reservationService, IPackageService packageService, IStudentRepository studentRepository) : ControllerBase
    {
        private readonly IReservationService _reservationService = reservationService;
        private readonly IPackageService _packageService = packageService;
        private readonly IStudentRepository _studentRepository = studentRepository;

        [HttpGet("Student/{studentId}")]
        public ICollection<Package>? GetReservations(Guid studentId)
        {
            return _reservationService.GetReservationsByStudentId(studentId);
        }

        [HttpPost("Package/{packageId}")]
        public async Task<Package?> ReservePackage(Guid packageId)
        {
            var studentClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (studentClaim == null)
            {
                return null;
            }

            var student = _studentRepository.GetByIdentityId(studentClaim);

            return await _reservationService.ReservePackageAsync(packageId!, student!.Id);
        }
    }
}
