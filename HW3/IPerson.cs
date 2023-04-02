

namespace HW3
{
    public interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //
        abstract public void DisplayInfo();
    }   
}
