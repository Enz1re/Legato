﻿using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.Interfaces
{
    public enum GuitarType
    {
        Classical = 1,
        Western = 2,
        Electric = 3,
        Bass = 4
    }

    public interface ILegatoManageServiceWorker
    {
        void Add(GuitarViewModel guitar, GuitarType type);

        void Edit(GuitarViewModel guitar, GuitarType type);

        void Remove(int id, GuitarType type);
    }
}
