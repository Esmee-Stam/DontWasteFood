using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DontWasteFood.WebApi.Controllers
{
    [Authorize(Policy = nameof(UserRole.Student))]
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
    }
}
