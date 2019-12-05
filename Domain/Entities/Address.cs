using Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Address : AuditableEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// navigation property for Flats
        /// </summary>
        public int FlatId { get; set; }
        /// <summary>
        /// Flat
        /// </summary>
        public Flat Flat { get; set; }
        /// <summary>
        /// Disctrict of city
        /// </summary>
        public District District { get; set; }
        /// <summary>
        /// Street
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// House number
        /// </summary>
        public int House { get; set; }
        /// <summary>
        /// House`s corpus
        /// </summary>
        public int Corpus { get; set; }
        /// <summary>
        /// Entrance number
        /// </summary>
        public int Entrance { get; set; }
    }
}
