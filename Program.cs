namespace ODataDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
           builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


            /*builder.Services.AddControllers().AddOData(options =>
                options.Select().Filter().OrderBy().Expand().Count());*/

            builder.Services.AddControllers().AddOData(opt => opt.AddRouteComponents("api", ODataConfig.GetEdmModel())
                        .Select()
                        .Expand()
                        .Filter()
                        .OrderBy()
                        .SetMaxTop(100)
                        .Count());
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IInstructorRepository, InstructorRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
