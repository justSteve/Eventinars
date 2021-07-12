using AutoMapper;
using Eventinars.Application.Interfaces.Chat;
using Eventinars.Application.Models.Chat;
using Eventinars.Infrastructure.Models.Identity;

namespace Eventinars.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}