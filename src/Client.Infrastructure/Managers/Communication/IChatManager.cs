using Eventinars.Application.Models.Chat;
using Eventinars.Application.Responses.Identity;
using Eventinars.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Eventinars.Application.Interfaces.Chat;

namespace Eventinars.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}