using AuthSvc.Application.DTOs;

namespace AuthSvc.Application.HandlerResponse;

public class Response
{
    public string Message { get; set; }
    public int Status { get; set; }
    public UserResponseDTO? Data { get; set; }

    public Response(string message, int status)
    {
        Message = message;
        Status = status;
    }

    public Response(string message, int status, UserResponseDTO data)
    {
        Message = message;
        Status = status;
        Data = data;
    }
}