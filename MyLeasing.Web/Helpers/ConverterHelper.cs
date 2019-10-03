using System.Collections.Generic;
using MyLeasing.Web.Data;
using MyLeasing.Web.Data.Entities;
using MyLeasing.Web.Models;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace MyLeasing.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        private readonly DataContext _dataContext;

        public ConverterHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Property> ToPropertyAsync(PropertyViewModel view, bool isNew)
        {
            return new Property
            {
                Address = view.Address,
                HasParkingLot = view.HasParkingLot,
                Id = isNew ? 0 : view.Id,
                IsAvailable = view.IsAvailable,
                Neighborhood = view.Neighborhood,
                Price = view.Price,
                Rooms = view.Rooms,
                SquareMeters = view.SquareMeters,
                Stratum = view.Stratum,
                Owner = await _dataContext.Owners.FindAsync(view.OwnerId),
                PropertyImages = isNew ? new List<PropertyImage>() : view.PropertyImages,
                PropertyType = await _dataContext.PropertyTypes.FindAsync(view.PropertyTypeId),
                Remarks = view.Remarks
            };
        }

        public Task<Property> ToPropertyAsync(PropertyViewModel view)
        {
            throw new NotImplementedException();
        }
    }
}
