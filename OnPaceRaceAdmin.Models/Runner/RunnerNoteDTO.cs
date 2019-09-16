
using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models
{

    public class RunnerNoteDTO : IEntity<RunnerNoteDTO,RunnerNote>
    {
        public int Id { get; set; }
        public int RunnerId { get; set; }
        [Display(Name ="Note Text")]
        [Required]
        public string Note { get; set; }
        [Display(Name ="Date Added")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateAdded { get; set; }

        public RunnerNoteDTO MapToDTO(RunnerNote entity)
        {
            return new RunnerNoteDTO()
            {
                Id = entity.Id,
                RunnerId = entity.RunnerId,
                Note = entity.Note,
                DateAdded = entity.DateAdded
            };
        }

        public RunnerNote MapToEntity(RunnerNoteDTO dto)
        {
            return new RunnerNote()
            {
                Id = dto.Id,
                RunnerId = dto.RunnerId,
                Note = dto.Note,
                DateAdded = dto.DateAdded
            };
        }
    }
}
