namespace OnionArchitectureExample.Application.Wrappers
{
    public class PagedResponse<T> : ServiceResponse<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public PagedResponse(T value) : base(value)
        {
        }

        public PagedResponse() : this(1, 10)
        {

        }

        public PagedResponse(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

    }
}
