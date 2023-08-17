<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>

<style>
    table, tr, th, td{
            border: solid red 2px;
            border-collapse: collapse;
            padding: 4px;
        }
</style>
</head>
<body>
    
    <FORM>
        <table border="1">
            <tr>
                <td>이름</td>
                <td><INPUT TYPE="text" NAME="name"></td>
            </tr>
            <tr>
                <td>나이</td>
                <td><INPUT TYPE="text" NAME="age"></td>
            </tr>
            <tr>
                <td>패스워드</td>
                <td><INPUT TYPE="password" NAME="pwd"></td>
            </tr>
        </table>      
        개인정보 : <INPUT TYPE="radio" NAME="info" CHECKED> 공개
                <INPUT TYPE="radio" NAME="info"> 비공개<br>
        
        취미 : <INPUT TYPE="checkbox" NAME="hobby"> 등산
               <INPUT TYPE="checkbox" NAME="hobby" CHECKED> 독서
               <INPUT TYPE="checkbox" NAME="hobby" CHECKED> 영화감상
               <INPUT TYPE="checkbox" NAME="hobby"> 음악감상
                <p>
        이메일 : <INPUT TYPE="text">@
                <SELECT>
                    <OPTION>선택</OPTION>
                    <OPTION>naver.com</OPTION> 
                    <OPTION>daum.net</OPTION> 
                    <OPTION>gmail.com</OPTION>
                    <OPTION>직접입력</OPTION>
                </SELECT> <p>
        
        내용 : <TEXTAREA rows="10" cols="30"></TEXTAREA> 
        <br>
        <button type="button">검색</button>
        <button type="submit">확인</button>
        <button type="reset">되돌리기</button>
        <p>
        파일첨부 : <INPUT type="file">*2MB까지 가능
        <p>
        <INPUT TYPE="color"><br>
        <INPUT TYPE="datetime-local"><br>
        <INPUT TYPE="month"><br>
        <INPUT TYPE="number"><br>
        <INPUT TYPE="range"><br>
        <INPUT TYPE="table"><br>
        <INPUT TYPE="week"><br>

    </FORM>
    
</body>
</html>
