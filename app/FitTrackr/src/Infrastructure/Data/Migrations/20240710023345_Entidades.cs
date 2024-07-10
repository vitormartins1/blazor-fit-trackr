using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitTrackr.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Entidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyRegions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyRegions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntensityLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntensityLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryFunctions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryFunctions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseTypeId = table.Column<int>(type: "int", nullable: false),
                    IntensityLevelId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_ExerciseTypes_ExerciseTypeId",
                        column: x => x.ExerciseTypeId,
                        principalTable: "ExerciseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exercises_IntensityLevels_IntensityLevelId",
                        column: x => x.IntensityLevelId,
                        principalTable: "IntensityLevels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Muscles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyRegionId = table.Column<int>(type: "int", nullable: false),
                    PrimaryFunctionId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muscles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Muscles_BodyRegions_BodyRegionId",
                        column: x => x.BodyRegionId,
                        principalTable: "BodyRegions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Muscles_PrimaryFunctions_PrimaryFunctionId",
                        column: x => x.PrimaryFunctionId,
                        principalTable: "PrimaryFunctions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPhases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingPlanId = table.Column<int>(type: "int", nullable: false),
                    PhaseNumber = table.Column<int>(type: "int", nullable: false),
                    TrainingDays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeekCount = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPhases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingPhases_TrainingPlans_TrainingPlanId",
                        column: x => x.TrainingPlanId,
                        principalTable: "TrainingPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentExercise",
                columns: table => new
                {
                    EquipmentsId = table.Column<int>(type: "int", nullable: false),
                    ExercisesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentExercise", x => new { x.EquipmentsId, x.ExercisesId });
                    table.ForeignKey(
                        name: "FK_EquipmentExercise_Equipments_EquipmentsId",
                        column: x => x.EquipmentsId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentExercise_Exercises_ExercisesId",
                        column: x => x.ExercisesId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseMuscle",
                columns: table => new
                {
                    ExercisesId = table.Column<int>(type: "int", nullable: false),
                    MusclesTargetedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseMuscle", x => new { x.ExercisesId, x.MusclesTargetedId });
                    table.ForeignKey(
                        name: "FK_ExerciseMuscle_Exercises_ExercisesId",
                        column: x => x.ExercisesId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseMuscle_Muscles_MusclesTargetedId",
                        column: x => x.MusclesTargetedId,
                        principalTable: "Muscles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingPhaseId = table.Column<int>(type: "int", nullable: false),
                    WeekNumber = table.Column<int>(type: "int", nullable: false),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingSessions_TrainingPhases_TrainingPhaseId",
                        column: x => x.TrainingPhaseId,
                        principalTable: "TrainingPhases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingSessionId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    OrderPriority = table.Column<int>(type: "int", nullable: false),
                    RepetitionSet_RepetitionMax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RepetitionSet_RepetitionMin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RepetitionSet_Set = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseSessions_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseSessions_TrainingSessions_TrainingSessionId",
                        column: x => x.TrainingSessionId,
                        principalTable: "TrainingSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseNoteExerciseSession",
                columns: table => new
                {
                    ExerciseSessionsId = table.Column<int>(type: "int", nullable: false),
                    NotesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseNoteExerciseSession", x => new { x.ExerciseSessionsId, x.NotesId });
                    table.ForeignKey(
                        name: "FK_ExerciseNoteExerciseSession_ExerciseNotes_NotesId",
                        column: x => x.NotesId,
                        principalTable: "ExerciseNotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseNoteExerciseSession_ExerciseSessions_ExerciseSessionsId",
                        column: x => x.ExerciseSessionsId,
                        principalTable: "ExerciseSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentExercise_ExercisesId",
                table: "EquipmentExercise",
                column: "ExercisesId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseMuscle_MusclesTargetedId",
                table: "ExerciseMuscle",
                column: "MusclesTargetedId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseNoteExerciseSession_NotesId",
                table: "ExerciseNoteExerciseSession",
                column: "NotesId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExerciseTypeId",
                table: "Exercises",
                column: "ExerciseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_IntensityLevelId",
                table: "Exercises",
                column: "IntensityLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseSessions_ExerciseId",
                table: "ExerciseSessions",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseSessions_TrainingSessionId",
                table: "ExerciseSessions",
                column: "TrainingSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Muscles_BodyRegionId",
                table: "Muscles",
                column: "BodyRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Muscles_PrimaryFunctionId",
                table: "Muscles",
                column: "PrimaryFunctionId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPhases_TrainingPlanId",
                table: "TrainingPhases",
                column: "TrainingPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSessions_TrainingPhaseId",
                table: "TrainingSessions",
                column: "TrainingPhaseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentExercise");

            migrationBuilder.DropTable(
                name: "ExerciseMuscle");

            migrationBuilder.DropTable(
                name: "ExerciseNoteExerciseSession");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Muscles");

            migrationBuilder.DropTable(
                name: "ExerciseNotes");

            migrationBuilder.DropTable(
                name: "ExerciseSessions");

            migrationBuilder.DropTable(
                name: "BodyRegions");

            migrationBuilder.DropTable(
                name: "PrimaryFunctions");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "TrainingSessions");

            migrationBuilder.DropTable(
                name: "ExerciseTypes");

            migrationBuilder.DropTable(
                name: "IntensityLevels");

            migrationBuilder.DropTable(
                name: "TrainingPhases");

            migrationBuilder.DropTable(
                name: "TrainingPlans");
        }
    }
}
