function distinct(value, index, self) {
    return self.indexOf(value) === index;
}

function kek(hashtags) {
    if(hashtags.length === 0) {
        return '';
    }
    const tags = [];
    hashtags.forEach(tag => {
        tags.push(tag.toLowerCase());
    })
    const uniqueTags = tags.filter((value, index, self) => self.indexOf(value) === index).join(', ');
    return uniqueTags.toString();
}
function xui () {
 let a = kek(['web', 'coursera', 'JavaScript', 'Coursera', 'script', 'programming', 'JS', 'js', 'js']);
 console.log(a);
}

xui()