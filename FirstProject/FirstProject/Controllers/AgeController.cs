using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    [NonController]
    public class AgeController
    {
        public string TestAge ()
        {
            return "test de age sur controller";
        }
    }
}
