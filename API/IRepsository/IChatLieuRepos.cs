using API.Models;

namespace API.IRepsository
{
    public interface IChatLieuRepos
    {
        bool AddChatLieu(Chatlieu chatlieu);
        bool RemoveChatLieu(Guid id);
        bool UpdateChatLieu(Guid id , Chatlieu chatlieu);
        List<Chatlieu> GetAll();
    }
}
