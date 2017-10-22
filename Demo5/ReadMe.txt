Install entity framework core, design  from NuGet Package manager

Create DbContext (Any class derived from DbContext) 
Add connection string to appsetting.json  
Use this connection string in Db context constructor 

 public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

Add the code 
services.AddDbContext<AppDbContext>(o =>
                o.UseSqlServer(Configuration.GetConnectionString("SalesConnectionString"))); 

				To Startup.cs 


1. Create Models (Customer, Order ....) 
2. Add DbSet<Model> // public DbSet<Customer> Customers { get; set; }  
3. add-migration "MigrationName"  //For example add-migration "CreateCustomer" 
4. update-database 



Homework

Confirm delete 
Create details action 