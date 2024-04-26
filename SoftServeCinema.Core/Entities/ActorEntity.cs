﻿using SoftServeCinema.Core.Interfaces;

namespace SoftServeCinema.Core.Entities
{
    public class ActorEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<MovieEntity> Movies { get; set; } = [];
    }
}