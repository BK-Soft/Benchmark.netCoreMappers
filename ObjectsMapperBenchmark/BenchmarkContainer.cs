using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AutoMapper;
using BenchmarkDotNet.Attributes;
using Mapster;
using Nelibur.ObjectMapper;
using Newtonsoft.Json;
using ObjectsMapperBenchmark.Dto;
using ObjectsMapperBenchmark.Entities;

namespace ObjectsMapperBenchmark
{
    public class BenchmarkContainer
    {
        private readonly SpotifyAlbumDto _spotifyAlbumDto = null;
        private readonly IMapper _autoMapper;
        public BenchmarkContainer()
        {
            var json = File.ReadAllText("spotifyAlbum.json");
            _spotifyAlbumDto=SpotifyAlbumDto.FromJson(json); 

    
            
       
        //Console.WriteLine(JsonConvert.SerializeObject(_spotifyAlbumDto));

              //Automapper Configuration 
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SpotifyAlbumDto, SpotifyAlbum>();
                cfg.CreateMap<CopyrightDto, Copyright>();
                cfg.CreateMap<ArtistDto, Artist>();
                cfg.CreateMap<ExternalIdsDto, ExternalIds>();
                cfg.CreateMap<ExternalUrlsDto, ExternalUrls>();
                cfg.CreateMap<TracksDto, Tracks>();
                cfg.CreateMap<ImageDto, Image>();
                cfg.CreateMap<ItemDto, Item>();
                cfg.CreateMap<SpotifyAlbum, SpotifyAlbumDto>();
                cfg.CreateMap<Copyright, CopyrightDto>();
                cfg.CreateMap<Artist, ArtistDto>();
                cfg.CreateMap<ExternalIds, ExternalIdsDto>();
                cfg.CreateMap<ExternalUrls, ExternalUrlsDto>();
                cfg.CreateMap<Tracks, TracksDto>();
                cfg.CreateMap<Image, ImageDto>();
                cfg.CreateMap<Item, ItemDto>();
            });

            _autoMapper = mapperConfig.CreateMapper();
            //TinyMapper Configuration 
            TinyMapper.Bind<SpotifyAlbumDto, SpotifyAlbum>();
            TinyMapper.Bind<CopyrightDto, Copyright>();
            TinyMapper.Bind<ArtistDto, Artist>();
            TinyMapper.Bind<ExternalIdsDto, ExternalIds>();
            TinyMapper.Bind<ExternalUrlsDto, ExternalUrls>();
            TinyMapper.Bind<TracksDto, Tracks>();
            TinyMapper.Bind<ImageDto, Image>();
            TinyMapper.Bind<ItemDto, Item>();
            TinyMapper.Bind<SpotifyAlbum, SpotifyAlbumDto>();
            TinyMapper.Bind<Copyright, CopyrightDto>();
            TinyMapper.Bind<Artist, ArtistDto>();
            TinyMapper.Bind<ExternalIds, ExternalIdsDto>();
            TinyMapper.Bind<ExternalUrls, ExternalUrlsDto>();
            TinyMapper.Bind<Tracks, TracksDto>();
            TinyMapper.Bind<Image, ImageDto>();
            TinyMapper.Bind<Item, ItemDto>();


        }
    

    [Benchmark]
    public SpotifyAlbum MapWithTinyMapper()
    {
        var spotifyAlbum = TinyMapper.Map<SpotifyAlbum>(_spotifyAlbumDto);
        return spotifyAlbum;

    }
    [Benchmark]
    public SpotifyAlbum MapWithAutoMapper()
    {

        var spotifyalbum = _autoMapper.Map<SpotifyAlbum>(_spotifyAlbumDto);
        return spotifyalbum;

    }
        [Benchmark]
        public SpotifyAlbum MapWithMapster()
        {

            var spotifyalbum = _spotifyAlbumDto.Adapt<SpotifyAlbum>();
            return spotifyalbum;

        }

    }
}
