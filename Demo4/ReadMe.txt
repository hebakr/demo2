Install entity framework from NuGet Package manager 
Create Models (Customer, Order ....) 

Create DbContext (Any class derived from DbContext) 
Add connection string to web.config 
Use this connection string in Db context constructor 
protected AppDbContext() : base("name=myConnection")
        {

        } 

 public DbSet<Customer> Customers { get; set; } 

 enable-migrations 
