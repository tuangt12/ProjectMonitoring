namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerFormatter()
    export class SCMUserNameFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext) {
            // Lấy giá trị id của từng dòng trong cột UserName
            let idUser = ctx.value as number;

            // Config tìm kiếm trong bảng User theo Id
            let byId = Administration.UserRow.getLookup().itemById;

            // Tìm kiếm trong bảng User với idUser vừa lấy được phía trên
            let userName = byId[idUser];
            // Nếu không có thì để trống
            if (!userName)
                return "";
            // Mặc đinh hiển thị tên tác giả, lấy theo trường DisplayName trong bảng User
            return Q.htmlEncode(userName.DisplayName);
        }
    }
}