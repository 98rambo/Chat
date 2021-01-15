using Chat.Data.Interfaces;
using Chat.Data.Models;
using Chat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Controllers
{
    public class HomeController : Controller
    {
        //Используем интерфейс, его реализует класс msgRepository
        private readonly IMessage _AllMessages;

        public HomeController(IMessage iMessage)
        {
            _AllMessages = iMessage;
        }

        public IActionResult Index()
        {
            MessagesIndexViewModel Obj = new MessagesIndexViewModel();
            Obj.AllMessages = _AllMessages.AllMessages;
            //obj.btnText = "Добавить";
            Obj.Msg = new Message();
            return View(Obj);
        }

        [HttpPost]
        public IActionResult Index(MessagesIndexViewModel Obj)
        {
            _AllMessages.AddMessage(Obj.Msg);
            Obj.AllMessages = _AllMessages.AllMessages;
            return View(Obj);
        }

    }
}
