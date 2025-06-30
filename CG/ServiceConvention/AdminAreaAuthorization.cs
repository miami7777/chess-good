using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace CG.ServiceConvention
{
    public class AdminAreaAuthorization : IControllerModelConvention
    {
        private readonly string _area;
        private readonly string _policy;

        public AdminAreaAuthorization(string area, string policy)
        {
            _area = area;
            _policy = policy;
        }

        public void Apply(ControllerModel controller)
        {
            var selectors = controller.Selectors;
            var hasRouteAttributes = controller.Selectors.Any(selector => selector.AttributeRouteModel != null);
            if (hasRouteAttributes)
            {
                return;
            }

            var controllerTypeNamespace = controller.ControllerType.Namespace;
            if (controllerTypeNamespace == null)
                return;

            var areaName = controllerTypeNamespace.Split('.').SkipWhile(segment => segment != "Areas").Skip(1).FirstOrDefault();


            if (!string.IsNullOrEmpty(areaName) && areaName.Equals(_area, StringComparison.OrdinalIgnoreCase))
            {
               controller.Filters.Add(new AuthorizeFilter(_policy));
            }            
        }
    }
}
