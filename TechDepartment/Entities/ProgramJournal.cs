using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDepartment.Enums;

namespace TechDepartment.Entities
{
    public class ProgramJournal : _Base
    {
        /// <summary>
        /// ДСЕ
        /// </summary>
        public Detail Detail { get; set; }

        /// <summary>
        /// Что сделано (токарная с ЧПУ, фрезерная, проволочно-вырезная)
        /// </summary>
        [MaxLength(100)]
        public string WhatsDone { get; set; }

        /// <summary>
        /// Станок
        /// </summary>
        public Machine Machine { get; set; }

        /// <summary>
        /// Время обработки по программе, часов
        /// </summary>
        public double ProgramTime { get; set; }

        /// <summary>
        /// Номер акта
        /// </summary>
        [MaxLength(10)]
        public string ActNumber { get; set; }

        /// <summary>
        /// Дата акта
        /// </summary>
        public DateTime? ActDate { get; set; }

        /// <summary>
        /// Местонахождение акта
        /// </summary>
        public ActStatus ActStatus { get; set; }

        /// <summary>
        /// Программист
        /// </summary>
        public Coworker Programmer { get; set; }

        /// <summary>
        /// Наличие техпроцесса
        /// </summary>
        public TPStatus TPStatus { get; set; }

        /// <summary>
        /// Наличие карты наладки
        /// </summary>
        public bool SetupCard { get; set; }

        /// <summary>
        /// Наличие проекта САМ системы
        /// </summary>
        public bool Project { get; set; }

        /// <summary>
        /// Наличие программ обработки
        /// </summary>
        public bool Program { get; set; }

        /// <summary>
        /// Аннулирован акт или нет
        /// </summary>
        public bool Annuled { get; set; }

        /// <summary>
        /// Путь до скана акта внедрения
        /// </summary>
        public string PathToAct { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        [MaxLength(150)]
        public string Notes { get; set; }

        public ProgramJournal() :base()
        {

        }

        public ProgramJournal(
            Detail detail, 
            string whatsDone, 
            Machine machine, 
            double programTime, 
            string actNum, 
            DateTime actDate, 
            ActStatus actStatus,
            Coworker programmer,
            TPStatus tpStatus,
            bool setupCard,
            bool project,
            bool program,
            bool annuled, 
            string pathToAct,
            string note) : this()
        {
            Detail = detail;
            WhatsDone = whatsDone;
            Machine = machine;
            ProgramTime = programTime;
            ActNumber = actNum;
            ActDate = actDate;
            ActStatus = actStatus;
            Programmer = programmer;
            TPStatus = tpStatus;
            SetupCard = setupCard;
            Project = project;
            Program = program;
            Annuled = annuled;
            PathToAct = pathToAct;
            Notes = note;

        }
    }
}
