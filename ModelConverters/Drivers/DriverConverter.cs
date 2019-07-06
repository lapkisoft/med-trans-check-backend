using System;
using Model = Models.Drivers;
using Client = ClientModels.Drivers;

namespace ModelConverters.Drivers
{
    public static class DriverConverter
    {
        public static Client.Driver Convert(Model.Driver modelDriver)
        {
            if (modelDriver == null)
            {
                throw new ArgumentNullException(nameof(modelDriver));
            }

            var clientTag = new Client.Driver
            {
                Id = modelDriver.Id.ToString(), 
                Mark = modelDriver.Mark,
                GovNumber = modelDriver.GovNumber
            };
            
            return clientTag;
        }
    }
}