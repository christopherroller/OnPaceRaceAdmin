namespace OnPaceRaceAdmin.Models.Contracts
{
    public interface IEntity<T, E> where T : class where E : class
    {
        int Id { get; set; }

        T MapToDTO(E entity);

        E MapToEntity(T dto);
    }
}
