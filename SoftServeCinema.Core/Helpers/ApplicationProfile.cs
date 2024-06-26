﻿using AutoMapper;
using SoftServeCinema.Core.DTOs.Actors;
using SoftServeCinema.Core.DTOs.Directors;
using SoftServeCinema.Core.DTOs.Genres;
using SoftServeCinema.Core.DTOs.Movies;
using SoftServeCinema.Core.DTOs.Payment;
using SoftServeCinema.Core.DTOs.Sessions;
using SoftServeCinema.Core.DTOs.Tags;
using SoftServeCinema.Core.DTOs.Tickets;
using SoftServeCinema.Core.DTOs.Users;
using SoftServeCinema.Core.Entities;

namespace SoftServeCinema.Core.Helpers
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<GenreEntity, GenreDTO>().ReverseMap();
            CreateMap<GenreEntity, GenreWithMoviesDTO>()
                .ForMember(
                    dest => dest.Movies,
                    opt => opt.MapFrom(src => src.Movies)
                );

            CreateMap<TagEntity, TagDTO>().ReverseMap();
            CreateMap<TagEntity, TagWithMoviesDTO>()
                .ForMember(
                    dest => dest.Movies,
                    opt => opt.MapFrom(src => src.Movies)
                );

            CreateMap<ActorEntity, ActorDTO>().ReverseMap();
            CreateMap<ActorEntity, ActorWithMoviesDTO>()
                .ForMember(
                    dest => dest.Movies,
                    opt => opt.MapFrom(src => src.Movies)
                );

            CreateMap<DirectorEntity, DirectorDTO>().ReverseMap();
            CreateMap<DirectorEntity, DirectorWithMoviesDTO>()
                .ForMember(
                    dest => dest.Movies,
                    opt => opt.MapFrom(src => src.Movies)
                );

            CreateMap<MovieEntity, MovieDTO>()
                .ForMember(
                    dest => dest.Genres,
                    opt => opt.MapFrom(src => src.Genres)
                )
                .ForMember(
                    dest => dest.Tags,
                    opt => opt.MapFrom(src => src.Tags)
                )
                .ForMember(
                    dest => dest.Directors,
                    opt => opt.MapFrom(src => src.Directors)
                );

            CreateMap<MovieEntity, MovieFullDTO>()
                .ForMember(
                    dest => dest.Genres,
                    opt => opt.MapFrom(src => src.Genres)
                )
                .ForMember(
                    dest => dest.Tags,
                    opt => opt.MapFrom(src => src.Tags)
                )
                .ForMember(
                    dest => dest.Directors,
                    opt => opt.MapFrom(src => src.Directors)
                )
                .ForMember(
                    dest => dest.Actors,
                    opt => opt.MapFrom(src => src.Actors)
                )
                .ForMember(
                    dest => dest.Sessions,
                    opt => opt.MapFrom(src => src.Sessions)
                );
            CreateMap<MovieFullDTO, MovieEntity>();

            CreateMap<MovieEntity, MovieFormDTO>()
                .ForMember(
                    dest => dest.SelectedGenres,
                    opt => opt.MapFrom(src => src.Genres.Select(g => g.Id))
                )
                .ForMember(
                    dest => dest.SelectedTags,
                    opt => opt.MapFrom(src => src.Tags.Select(t => t.Id))
                )
                .ForMember(
                    dest => dest.SelectedDirectors,
                    opt => opt.MapFrom(src => src.Directors.Select(d => d.Id))
                )
                .ForMember(
                    dest => dest.SelectedActors,
                    opt => opt.MapFrom(src => src.Actors.Select(a => a.Id))
                );
            CreateMap<MovieFormDTO, MovieEntity>();

            CreateMap<SessionEntity, SessionDTO>()
                .ForMember(
                    dest => dest.Tickets,
                    opt => opt.MapFrom(src => src.Tickets)
                );
            CreateMap<SessionDTO, SessionEntity>();

            CreateMap<SessionEntity, SessionDetailsDTO>()
              .ForMember(
                  dest => dest.Tickets,
                  opt => opt.MapFrom(src => src.Tickets)
              );
            CreateMap<SessionDetailsDTO, SessionEntity>();


            CreateMap<TicketEntity, TicketDTO>().ReverseMap();
            CreateMap<TicketDTO, TicketEntity>();
            CreateMap<TicketEntity, TicketDetailDTO>();
            CreateMap<TicketEntity, TicketDetailWithUserDTO>().ReverseMap();


            CreateMap<PaymentEntity, PaymentDTO>().ReverseMap();
            CreateMap<PaymentEntity, PaymentDTO>();

            CreateMap<UserEntity, UserDTO>().ReverseMap();
            CreateMap<UserEntity, UserLoginDTO>().ReverseMap();
            CreateMap<UserEntity, UserRegisterDTO>().ReverseMap();
            CreateMap<UserEntity, UserWithTicketsDTO>()
                .ForMember(
                    dest => dest.Tickets,
                    opt => opt.MapFrom(src => src.Tickets)
                );

        //CreateMap<UserEntity, UserWithTicketsDTO>()
        //    .ForMember(
        //         dest => dest.Tickets,
        //          opt => opt.MapFrom(src => src.Tickets.Where(ticket => ticket.UserId == src.Id)
        //    .Select(ticket => new TicketDTO
        //    {

        //    }.ToString()))
        //    );


        }
    }
}
