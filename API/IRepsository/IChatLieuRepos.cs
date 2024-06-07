using API.Models;

namespace API.IRepsository
{
    public interface ISanPhamRepos
    {
        bool AddChatLieu(Chatlieu chatlieu);
        bool RemoveChatLieu(Guid id);
        bool UpdateChatLieu(Guid id , Chatlieu chatlieu);
        list
    }
}
