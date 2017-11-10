var gulp = require('gulp');
var build = require('gulp-build');

gulp.task('default', function() {
  // place code for your default task here
});

gulp.task("kompiluj", function() {
    gulp.src("*.ts").pipe(build()).pipe(gulp.dest('skompilovane'));
});