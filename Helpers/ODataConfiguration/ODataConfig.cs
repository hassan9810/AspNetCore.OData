namespace ODataDemo.Helpers.ODataConfiguration
{
    public static class ODataConfig
    {
        public static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Instructor>("Instructors");
            return builder.GetEdmModel();
        }
    }
}
