// See https://aka.ms/new-console-template for more information

using AdapterDesignPattern;

Console.WriteLine("Adapter Design Pattern");
ITarget target = new EmployeeAdapter();
ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem(target);
thirdPartyBillingSystem.ShowEmployeeList();
