﻿using Enceja.Domain.Entities;

namespace Enceja.Domain.Interfaces
{
    public interface IGradeService : IBaseService<Grade>
    {
        Task<IEnumerable<Grade>> GetGradeBySubjectOfStudent(int studentId);
    }
}
