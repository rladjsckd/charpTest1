<!DOCTYPE html>
<html lang="ko"> 
<head>
   <meta charset="UTF-8">
   <title>Document</title>

    <style>
        table, tr, th, td{
            border: solid black 1px;
            border-collapse: collapse;
            padding: Spx;
        }
    </style>
</head>
<body>
<h3>오늘의 날씨</h3>
    <table>
        <tr>
            <th>지역</th>
            <th>현재기온</th>
            <th colspan="2">불쾌지수/습도(%)</th>
            <th>풍속(m/s)</th>
        </tr>
        <tr>
            <td rowspan="2">서울/경기</td>
            <td>23</td>
            <td>60</td>
            <td>80</td>
            <td>4.7</td>
        </tr>
        <tr>
            <td>20</td>
            <td>60</td>
            <td>80</td>
            <td>5.0</td>
        </tr>
        <tr>
            <td>제주도</td>
            <td>21</td>
            <td>65</td>
            <td>85</td>
            <td>3.6</td>
        </tr>
    </table>


</body>
</html>
