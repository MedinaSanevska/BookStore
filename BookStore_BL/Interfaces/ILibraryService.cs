﻿
namespace BookStore_BL.Interfaces
{
    public interface ILibraryService
    {
        public GetAllBookByAuthorResponse
            GetAllBookByAuthorAfterDate(GetAllBookByAuthorRequest request);
        public int CheckAuthorCount(int input);

      
    }
}

