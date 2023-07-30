using Microsoft.EntityFrameworkCore;
using QuizApp.Business.Validators.Generics;
using QuizApp.Data;
using QuizApp.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Business.Generics
{
    public abstract class GenericService<TDto, TSummary, TEntity> : IGenericService<TDto, TSummary> where TEntity : class, IEntity, new()
    {
        protected readonly QuizDbContext _dbContext;
        protected readonly IValidator<TEntity> _validator;
        public GenericService(QuizDbContext dbContext, IValidator<TEntity> validator)
        {
            _dbContext = dbContext;
            _validator = validator;
        }
        protected abstract TEntity MapToEntity(TDto entity);
        protected abstract Expression<Func<TEntity, TDto>> DtoMapper { get; }
        protected abstract Expression<Func<TEntity, TSummary>> SummaryMapper { get; }
        public virtual CommandResult Create(TDto dto)
        {
            try
            {
                var entity = MapToEntity(dto);
                var validationResult = _validator.Validate(entity);
                if (!validationResult.IsValid)
                {
                    var validationMessages = string.Join('\n', validationResult.Messages);
                    return CommandResult.Failure(validationMessages);
                }
                _dbContext.Set<TEntity>().Add(entity);
                _dbContext.SaveChanges();
                return CommandResult.Success();
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return CommandResult.Failure();

            }
        }
        public virtual CommandResult Delete(TDto dto)
        {
            var entity = MapToEntity(dto);
            return Delete(entity.Id);
        }
        public virtual CommandResult Delete(int id)
        {
            try
            {
                var entity = new TEntity() { Id = id };
                if (entity != null)
                {
                    _dbContext.Set<TEntity>().Remove(entity);
                    _dbContext.SaveChanges();

                    return CommandResult.Success();
                }
                else
                {
                    return CommandResult.Failure("Kayıt bulunamadı");
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return CommandResult.Failure();
            }
        }
        public virtual IEnumerable<TDto> GetAll()
        {
            try
            {
                return _dbContext.Set<TEntity>()
                      .Select(DtoMapper)
                      .ToList();
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return Enumerable.Empty<TDto>();
            }
        }
        public virtual TDto? GetById(int id)
        {
            try
            {
                return _dbContext.Set<TEntity>()
                    .Where(x => x.Id == id)
                    .Select(DtoMapper)
                    .SingleOrDefault();
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return default;
            }
        }

        public virtual IEnumerable<TSummary> GetSummaries()
        {
            try
            {
                return _dbContext.Set<TEntity>()
                       .Select(SummaryMapper)
                       .ToList();
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return Enumerable.Empty<TSummary>();
            }
        }
        public virtual TSummary? GetSummaryById(int id)
        {
            try
            {
                return _dbContext.Set<TEntity>()
                        .Where(x => x.Id == id)
                        .Select(SummaryMapper)
                        .SingleOrDefault();
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return default;
            }
        }
        public virtual CommandResult Update(TDto dto)
        {
            try
            {
                var entity = MapToEntity(dto);
                _dbContext.Set<TEntity>().Update(entity);
                _dbContext.SaveChanges();
                return CommandResult.Success();
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return CommandResult.Failure();
            }
        }
    }

}
