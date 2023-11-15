using RealPromoApiWeb.Models;
using Microsoft.AspNetCore.SignalR;

namespace RealPromoApiWeb.Hubs
{
    public class PromoHub:Hub
    {
        public async Task CadastrarPromocao(Promocao promocao)
        {
           await Clients.Caller.SendAsync("CadastradoSucesso");
           await Clients.Others.SendAsync("ReceberPromocao", promocao);
        }

    }
}
