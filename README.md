# DapperVsEFAssignment

Issues need to be fixed



1.  	Assignment.StoreEF.Mappings --> Need to provide List mapping / fix mapping error for
		CreateMap<List<Domain.Models.Product> ,List<StoreEF.Tables.TblProduct>>();

2.	Assignment.Application.Services -> IProductRepository need to be assigned using factory  

3.  CleanArchitectAssignmentAPI -> Program.cs
	Select anyone store at a time base on configuration, 
		if (condition)
			builder.Services.AddInfrastructureEF(builder.Configuration);
		else
			builder.Services.AddInfrastructureDapper(builder.Configuration);


