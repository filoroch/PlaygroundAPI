public class UserDTO
{
    public string username { get; init; }
    public string email { get; init; }

    /// <summary>
    /// Converte um <c>UserModel</c> em um <c>UserReadModel</c> 
    /// </summary>
    /// <param name="userModel"><c>UserModel</c> que será convertido</param>
    /// <returns>Um novo <c>UserReadModel</c> referente ao <c>UserModel</c></returns>
    public static UserDTO FromUserModel(UserModel userModel) => new()
    {
        username = userModel.username,
        email = userModel.email
    };
}
public class UserSigninRequestModel
{
    public string username { get; init; }
    public string email { get; init; }
    public string password { get; init; }
}
public class UserLoginRequestModel
{
    public string username { get; init; }
    public string password { get; init; }
}