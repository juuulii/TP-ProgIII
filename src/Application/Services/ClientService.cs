﻿using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public List<Client> GetClients()
    {
        return _clientRepository.GetAll();
    }

    public Client GetClientById(int id)
    {
        return _clientRepository.GetById(id);
    
    }

    public void AddClient(Client client)
    {
        _clientRepository.Add(client);
    }

    public void UpdateClient(int id, Client client)
    {
        _clientRepository.Update(id, client);
    
    }

    public void DeleteClient(int id)
    {
        var client = _clientRepository.GetById(id);
        _clientRepository.Delete(client);
    
    }
}
