using AutoMapper;
using TaskTranning.Models;

namespace TaskTranning.ViewModels.StockViewModel
{
    public class StockProfile : Profile
    {
        public StockProfile()
        {
            CreateMap<Stock, StockViewModel>();
        }
    }
}