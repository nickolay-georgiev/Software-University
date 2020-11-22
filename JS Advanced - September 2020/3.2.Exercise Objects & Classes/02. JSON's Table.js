function solve(json) {

    

    let result = "";

    result += "<table>\n";

    for (let i = 0; i < json.length; i++) {

        let text = JSON.parse(json[i]);

        result += "   <tr>\n";

        for (const key in text) {

            result += `     <td>${text[key]}</td>\n`;

        }

        result += "</tr>\n";

        for (let i = 0; i < text.length; i++) {
            const element = text[i];
            result += "   <tr>";

            for (const value in element) {
                let cellValue = String(element[value])
                    .replace(/&/gim, '&amp;')
                    .replace(/</gim, '&lt;')
                    .replace(/>/gim, '&gt;')
                    .replace(/"/gim, '&quot;')
                    .replace(/'/gim, '&#39;');

                result += `<td>${cellValue}</td>`;
            }

            result += "</tr>\n"
        }
    }
    result += "</table>";

    console.log(result);
}