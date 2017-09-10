$(function () {
    $(".search").on('click', function () {
        $("table tr:gt(0)").remove();
        $(".user").remove();
        $.get("/home/get", { word: $(".word").val() }, function (user) {
            $(".table").before(`<h4 class = user>${user.user.Name} ${user.user.Location} ${user.user.Followers}<h4>`);

            user.user.Repos.forEach(r => {
                var row = `<tr>
                            <td>${r.Name}</td>
                            <td>${r.Description}</td>
                            <td>${r.Watchers}</td>
                            <td>${r.Stars}</td>
                            </tr>`;
                $(".table").append(row);
            });
        }
    );
        $(".word").on('keyup', (function (e) {
            if (e.keyCode === 13) {
                $(".search").click();
            }
        })
        );

    });
});