namespace AnimalCentre.Models.Animal.Contracts
{
    public interface IProcedure
    {
        void DoService(Animal animal, int procedureTime);
    }
}
