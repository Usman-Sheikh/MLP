$.CategoryCourseJs = {
    Initialize: function () {
        $.CategoryCourseJs.OpenSearchForm();
    },
    OpenSearchForm: function () {
        jQuery('.sideBarMenu').click();
        $(".sideBarMenu").on("click", function (e) {
            var id = $(this).attr('data-id');
            $('ul.list-group li').removeClass('active');
            $(this).closest('li').addClass('active');
            var divCourcesName = $("#divCourcesName");
            $.ajax({
                url: '/Course/List',
                type: "GET",
                //contentType: 'application/json; charset=utf-8',
                data: { id: id },
                //async: true,
                //processData: false,
                cache: false,
                dataType: "html",
                success: function (data) {
                    divCourcesName.html('');
                    divCourcesName.html(data);
                },
                error: function (xhr) {
                    alert('error');
                }
            })
            
        });
    },
}