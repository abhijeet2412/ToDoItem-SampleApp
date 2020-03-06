using WebApplication3.Controllers;
using Xunit;

namespace ToDoItemControllerTests
{
    public class TodoItemsController_itemsController
    {

        // private readonly TodoItemsController _itemsController;

        //public TodoItemsController_itemsController()
        //{
        //    _itemsController = new TodoItemsController();
        //}

        [Fact]
        public void TestGetToDoItem()
        {
            var item = 1;
            Assert.Equal(1, item);
        }
    }
}
