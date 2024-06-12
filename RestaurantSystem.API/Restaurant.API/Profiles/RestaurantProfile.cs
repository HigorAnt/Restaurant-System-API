using AutoMapper;
using Restaurant.API.Models;
using Restaurant.API.Entities;

namespace Restaurant.API.Profiles;
public class RestaurantProfile : Profile
{
    public RestaurantProfile()
    {
        CreateMap<Snack, SnackDTO>().ReverseMap();
        CreateMap<Snack, SnackForCreateDTO>().ReverseMap();
        CreateMap<Snack, SnackForUpdateDTO>().ReverseMap();
        CreateMap<Ingredients, IngredientsDTO>().ForMember(d => d.SnackId, o => o.MapFrom(s => s.Snacks.First().Id));
    }
}
