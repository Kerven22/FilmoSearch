﻿using FilmoSearch.Contracts;
using FilmoSearch.Serivce.Contracts;

namespace FilmoSearch.Service
{
    public class CommentService:ICommentService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly ILoggerManager loggerManager;

        public CommentService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            this.repositoryManager = repositoryManager;
            this.loggerManager = loggerManager;
        }
    }
}