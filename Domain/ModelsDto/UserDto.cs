namespace Domain.ModelsDto
{
    public record UserDto(
        Guid Id, 
        string FirstName, 
        string SecondName, 
        int Age, 
        string Login, 
        string Emiail, 
        string Password); 
}
