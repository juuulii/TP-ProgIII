using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private static List<T> _entities = new List<T>();

    //2 metodos de lectura
    public List<T> GetAll() 
    { 
        return _entities;
    }

    public T GetById(int id) 
    {
        return _entities[id];
    }

    //Metodos de alta(o creacion), agrega una entidad a la lista

    public void Add(T entity)
    {
        _entities.Add(entity);
    }

    //Busca una entidad
    public void Update(int id, T entity)
    {
        _entities[id] = entity;
    }

    //Elimina una entidad
    public void Delete(T entity)
    {
        _entities.Remove(entity);
    }
}

//se crea un BaseRepository para ahorrarnos codigo y no poner lo mismo en todos los repositorios,
//hacemos q herenden de este
