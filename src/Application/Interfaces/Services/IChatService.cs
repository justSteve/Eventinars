using Eventinars.Application.Responses.Identity;
using Eventinars.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Eventinars.Application.Interfaces.Chat;
using Eventinars.Application.Models.Chat;

namespace Eventinars.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}