function solve(data, criteria) {
    console.log([...JSON.parse(data)
            .filter((v, _) =>
                v[criteria.split("-")[0]] === criteria.split("-")[1])
        ]
        .map((v, i) =>
            `${i}. ${v["first_name"]} ${v["last_name"]} - ${v["email"]}`, 0)
        .join("\n"));
}