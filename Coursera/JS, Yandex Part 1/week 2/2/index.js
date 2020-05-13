/**
 * @param {String[]} hashtags
 * @returns {String}
 */
module.exports = function (hashtags) {
    if(hashtags.length === 0) {
        return '';
    }
    const tags = [];
    hashtags.forEach(tag => {
        tags.push(tag.toLowerCase());
    })
    const uniqueTags = tags.filter((value, index, self) => self.indexOf(value) === index).join(', ');
    return uniqueTags.toString();
};
