//interface new'lenemez

IPersonManager customerManager = new CustomerManager();

IPersonManager employeeManager = new EmployeeManager();

IPersonManager internManager = new InternManager();

ProjectManager projectManager = new ProjectManager();
projectManager.Add(employeeManager);
projectManager.Add(customerManager);
projectManager.Add(internManager);


interface IPersonManager
{
    void Add();
    void Update();
}

//inheritance(kalıtım & miras) - class | implements - interface
class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Müşteri Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri Güncellendi");

    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Personel Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Personel Güncellendi");

    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer Güncellendi");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }

    
}