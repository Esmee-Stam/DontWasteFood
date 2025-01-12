using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DontWasteFood.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController(IReservationService reservationService, IPackageService packageService) : ControllerBase
    {
        private readonly IReservationService _reservationService = reservationService;
        private readonly IPackageService _packageService = packageService;

        [HttpGet("Student/{studentId}")]
        public ICollection<Package>? GetReservations(Guid studentId)
        {
            return _packageService.GetAllReservedPackagesByUserId(studentId);
        }

        [HttpPost("Package/{packageId}")]
        public Package? ReservePackage(Guid packageId)
        {
            var studentClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (studentClaim == null)
            {
                return null;
            }

            var studentId = Guid.Parse(studentClaim);

            return _reservationService.ReservePackage(packageId, studentId);

        }
    }
}
