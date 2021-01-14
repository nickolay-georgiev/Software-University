function solution(command) {

    let post = this;

    let functionCommands = {
        upvote,
        downvote,
        score,
    }

    function upvote() {
        post.upvotes++;
    }

    function downvote() {
        post.downvotes++;
    }

    function score() {
        let result = [];

        if (post.upvotes + post.downvotes > 50) {

            let obfuscatedNumber  = Math.ceil(Math.max(post.upvotes, post.downvotes) * 0.25);

            result.push(post.upvotes + obfuscatedNumber );
            result.push(post.downvotes + obfuscatedNumber );
        }
        else {
            result.push(post.upvotes);
            result.push(post.downvotes);
        }

        let balance = post.upvotes - post.downvotes;
        result.push(balance);
        result.push(getRating(post));

        return result;
    }

    function getRating(object) {
        let upVotes = object['upvotes'];
        let downVotes = object['downvotes'];
        let totalVotes = upVotes + downVotes;
        let balance = upVotes - downVotes;

        if (totalVotes < 10) {
            return 'new';
        }

        if ((upVotes / totalVotes) > 0.66) {
            return 'hot';
        }

        if ((downVotes / totalVotes <= 0.66) && balance >= 0 && (upVotes > 100 || downVotes > 100)) {
            return 'controversial';
        }

        if (balance < 0 && totalVotes >= 10) {
            return 'unpopular';
        }

        return 'new';
    }

    function manager(command) {
        let func = functionCommands[command];
        return func();
    };

    return manager(command);
}